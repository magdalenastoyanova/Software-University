import { create, get, update, close} from '../models/events.js';
import { setHeader } from './auth.js';
import commonPartial from './partials.js';

export function getCreate(ctx) {
    setHeader(ctx);
    ctx.loadPartials(commonPartial).partial('./view/shoes/create.hbs');
}

export function postCreate(ctx) {
    const { name, price, imageURL, description, brand} = ctx.params;
    if(name =='' && price =='' && imageURL =='' && description =='' && brand =='' ){
        return;
    }
    const creator = sessionStorage.getItem('user');
    create({ name, price, imageURL, description, brand, creator, peopleBoughtIt: 0})
    .then(res => {
     ctx.redirect('#/home')
    }). catch(e => console.log(e))
}

export function getDetails(ctx) {
    setHeader(ctx);
    const id = ctx.params.id;
    get(id)
    .then(res => {
        const shoe = {...res.data(), id: res.id};
        ctx.isCreator = shoe.creator === sessionStorage.getItem('user');
        ctx.shoe = shoe;
        ctx.loadPartials(commonPartial).partial('./view/shoes/details.hbs');
    }).catch(e => console.log(e));
}

export function getEdit(ctx) {
    setHeader(ctx);
    const id = ctx.params.id;
    get(id)
    .then(res => {
        const shoe = {...res.data(), id: res.id};
        ctx.shoe = shoe;
        ctx.loadPartials(commonPartial).partial('./view/shoes/edit.hbs');
    }).catch(e => console.log(e));
}

export function postEdit(ctx) {
    const id = ctx.params.id;
    const { name, price, imageURL, description, brand} = ctx.params;
    update(id, {name, price, imageURL, description, brand})
  .then( res => {
      ctx.redirect(`#/details/${id}`);
  }).catch(e => console.log(e));
}

export function getClose(ctx) {
    const id = ctx.params.id;
    close(id). then(res =>{
      ctx.redirect('#/home');
    }).catch(e => console.log(e));
}

export function getBuy(ctx) {
    const id = ctx.params.id;
    get(id)
    .then(res => {
        const shoe = res.data();
        const peopleBoughtIt = shoe.peopleBoughtIt + 1;
       update(id, {peopleBoughtIt})
       .then(() => {
           ctx.redirect(`#/details/${id}`);
       }).catch(e => console.log(e));
    }).catch(e => console.log(e));
}
