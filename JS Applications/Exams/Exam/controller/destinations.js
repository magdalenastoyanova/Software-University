
import { create, get, update, close } from '../models/events.js';
import { setHeader } from './auth.js';
import commonPartial from './partials.js';


export function getCreate(ctx) {
    setHeader(ctx);
    ctx.loadPartials(commonPartial).partial('./view/destinations/create.hbs');
}

export function postCreate(ctx) {
    const {destination, city, duration, departureDate, imageURL} = ctx.params;
    const creator = sessionStorage.getItem('user');
    if(destination =='' || city == '' || duration == '' ||  departureDate == '' || imageURL ==''){
        return;
    }
    create( {destination, city, duration, departureDate, imageURL, creator})
    .then(res => {
        notify('New destination created!', '#successBox')
       setTimeout(() => {
            ctx.redirect('#/home');

        }, 2000)
    }) 
    .catch(e => notify(`Inputs are not valid!`,'#errorBox'));
        
}

export function  getDetail(ctx){
    setHeader(ctx);
    const id  = ctx.params.id;
    get(id)
    .then(res => {
      const destination = {...res.data(), id: res.id};
       ctx.destination = destination;
       ctx.loadPartials(commonPartial).partial('./view/destinations/details.hbs');
    })
    .catch(a => console.log(a))
}

export function getEdit(ctx) {
    const id = ctx.params.id;
    
    get(id)
    .then(res => {
    const destination = {...res.data(), id: res.id};
       ctx.destination = destination;
       ctx.loadPartials(commonPartial).partial('./view/destinations/edit.hbs');
    })
    .catch(a => console.log(a))

}

export function postEdit(ctx) {
    const {destination, city, duration, departureDate, imageURL} = ctx.params;
    if(destination =='' || city == '' || duration == '' ||  departureDate == '' || imageURL ==''){
        return;
    }
    const id = ctx.params.id;
    update(id, {destination, city, duration, departureDate, imageURL})
    .then(res =>{
        notify("Successfully edited destination.", '#successBox')
        setTimeout(() => {
            ctx.redirect(`#/details/${id}`);

        }, 2000)
        
    })
    .catch( e => console.log(e));
}

export function  getDestinations(ctx) {
    setHeader(ctx);

       ctx.loadPartials(commonPartial).partial('./view/destinations/destinations.hbs');
   
    
}

export function getClose(ctx){
    const id = ctx.params.id;
    close(id).then(res => {
        ctx.redirect('#/home');
        })
        .catch(e => console.log(e));
}

function notify(message, selector) {
    const notification = document.querySelector(selector);
        notification.textContent = message;
        notification.style.display = 'block';
        
        notification.addEventListener('click', () =>{
            notification.style.display = 'none';
        });
    }
   