
import { create, get, update, close } from '../models/events.js';
import { setHeader } from './auth.js';
import commonPartial from './partials.js';

export function getCreate(ctx) {
    setHeader(ctx);
    ctx.loadPartials(commonPartial).partial('./view/movies/create.hbs');
}

export function postCreate(ctx) {
    const {title, description, imageURL} = ctx.params;
    const creator = sessionStorage.getItem('user');
    create( {title, description, imageURL, creator, likes: 0, peopleLiked: []})
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
      const movie = {...res.data(), id: res.id};
       ctx.movie = movie;
       ctx.isCreator = movie.creator === sessionStorage.getItem('user');
       ctx.loadPartials(commonPartial).partial('./view/movies/details.hbs');
    })
    .catch(a => console.log(a))
}

export function getEdit(ctx) {
    setHeader(ctx);
    const id = ctx.params.id;
    get(id)
    .then(res => {
        const movie = {...res.data(), id: res.id};
        ctx.movie = movie;
       ctx.loadPartials(commonPartial).partial('./view/movies/edit.hbs');
    })
    .catch(a => console.log(a))

}

export function postEdit(ctx) {
    const {title, description, imageURL} = ctx.params;
    const id = ctx.params.id;
    update(id, {title, description, imageURL})
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

export function getLiked(ctx) {
    const id = ctx.params.id;
    get(id)
    .then(res => {
        const movie = res.data();
        let peopleLiked = movie.peopleLiked;
        let likes = movie.likes;
        const creator = sessionStorage.getItem('user');
        
        if(!movie.peopleLiked.includes(creator)){
            movie.peopleLiked.push(creator);
            likes += 1;
        }
        update(id, {likes, peopleLiked})
        .then(() => {
            
            console.log(movie.peopleLiked);
            ctx.isLiked = Boolean(creator);
            console.log(ctx.isLiked);
            ctx.redirect(`#/details/${id}`);
            
       }).catch(e => console.log(e));
    }).catch(e => console.log(e));
}