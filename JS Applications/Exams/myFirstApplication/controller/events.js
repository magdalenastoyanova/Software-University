
import { create, get, update, close } from '../models/events.js';
import { setHeader } from './auth.js';
import commonPartial from './partials.js';

export function getCreate(ctx) {
    setHeader(ctx);
    ctx.loadPartials(commonPartial).partial('./view/events/create.hbs');
}

export function postCreate(ctx) {
    const {name, dateTime, description, imageURL} = ctx.params;
    const organizer = sessionStorage.getItem('user');
    create( {name, dateTime, description, imageURL, organizer, counter: 0, interestedIn: 0})
    .then(res => {
        console.log(res);
        ctx.redirect('#/home');
    })
    .catch(e => console.log(e))
}

export function  getDetail(ctx){
    setHeader(ctx);
    const id  = ctx.params.id;
    get(id)
    .then(res => {
      const event = {...res.data(), id: res.id};
       ctx.event = event;
       ctx.loadPartials(commonPartial).partial('./view/events/details.hbs');
    })
    .catch(a => console.log(a))
}

export function getEdit(ctx) {
    const id = ctx.params.id;
    
    get(id)
    .then(res => {
    const event = {...res.data(), id: res.id};
       ctx.event = event;
       ctx.loadPartials(commonPartial).partial('./view/events/edit.hbs');
    })
    .catch(a => console.log(a))

}

export function postEdit(ctx) {
    const {name, dateTime, description, imageURL} = ctx.params;
    const id = ctx.params.id;
    update(id, {name, dateTime, description, imageURL})
    .then(res =>{
        ctx.redirect(`#/details/${id}`);
    })
    .catch( e => console.log(e));
}

export function getClose(ctx){
    const id = ctx.params.id;
    close(id).then(res => {
        ctx.redirect('#/home');
        })
        .catch(e => console.log(e));
}

export function getJoin(ctx) {
    const id = ctx.params.id;
    get(id)
    .then(res => {
    const event = res.data();
       const interestedIn = event.interestedIn + 1;

       update(id, { interestedIn})
       .then(() =>{
           ctx.redirect(`#/details/${id}`);
       })
       .catch( e => console.log(e));
    })
    .catch(a => console.log(a));

}