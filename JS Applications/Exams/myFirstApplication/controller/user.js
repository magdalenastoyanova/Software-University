import { login, logout, registerUser } from '../models/user.js';
import { saveUserInfo, setHeader } from './auth.js';
import commonPartial from './partials.js';

export function getLogin(ctx){
    setHeader(ctx);
    ctx.loadPartials(commonPartial).partial('./view/user/login.hbs')
}

export function getProfile(ctx){
    setHeader(ctx);
    ctx.loadPartials(commonPartial).partial('./view/user/profile.hbs');
}

export function getRegister(ctx){
    setHeader(ctx);
    ctx.loadPartials(commonPartial).partial('./view/user/register.hbs')
}

export function postRegister(ctx) {
    const {username, password, rePassword} = ctx.params;
    if(password !== rePassword){
        throw new Error('Passwords do not match!');
    }
    registerUser(username, password)
    .then(res => {
        saveUserInfo(res.user.email); 
        notify('User registration successful.', '#successBox')
        setTimeout(() => {
            ctx.redirect('#/home');

        }, 2000)
    })
    .catch(e => notify(`Password do not match!`,'#errorBox'));
}

export function postLogin(ctx) {
    const {username, password} = ctx.params;
    login(username, password)
    .then(res => {
        saveUserInfo(res.user.email);
        notify('Logged in!', '#successBox')
        setTimeout(() => {
            ctx.redirect('#/home');

        }, 2000)

    })
    .catch(e => notify(`Password or username not correct!`,'#errorBox'));
    
}

export function getLogout(ctx) {
    logout()
    .then(res => {
       sessionStorage.clear();
       notify('Logout successful.', '#successBox')
        setTimeout(() => {
            ctx.redirect('#/home');

        }, 2000)
    })
    .catch(e => notify(`Logout not possible.`,'#errorBox'));
}

function notify(message, selector) {
    const notification = document.querySelector(selector);
        notification.textContent = message;
        notification.style.display = 'block';
        
        notification.addEventListener('click', () =>{
            notification.style.display = 'none';
        });
}