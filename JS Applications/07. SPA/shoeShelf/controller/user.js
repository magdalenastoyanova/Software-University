import { login, logout, registerUser } from '../models/user.js';
import { saveUserInfo } from './auth.js';
import commonPartial from './partials.js';


export function getLogin(ctx){
    ctx.loadPartials(commonPartial).partial('./view/user/login.hbs')
}

export  function getRegister(ctx){
    ctx.loadPartials(commonPartial).partial('./view/user/register.hbs')
}

export  function postRegister(ctx){

    const {username, password, rePassword} = ctx.params;
    if(!username || password.length != 6){
        return;
    }
    if(password !== rePassword) {
        throw new Error('Passwords do not match!');
    }
    registerUser(username, password)
    .then( res => {     
        saveUserInfo(res.user.email);
       
        ctx.redirect('#/home');
    })
    .catch(e => console.log(e));
}
 export function postLogin(ctx) {
    const {username, password} = ctx.params;
    login(username, password)
    .then(res => {
        saveUserInfo(res.user.email);
        ctx.redirect('#/home');
    }). catch(e => console.log(e));
 }

 export function getLogout(ctx) {
     logout()
     .then( () => {
       sessionStorage.clear();
       ctx.redirect('#/login')
     }).catch(e => console.log(е));
 }