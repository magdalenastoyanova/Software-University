
import { getAll } from '../models/events.js';
import { setHeader } from './auth.js';
import commonPartial from './partials.js';

export  function getHome(ctx){
     setHeader(ctx);
     getAll()
     .then( res => {
         const shoes = res.docs.map(x => x = {...x.data(), id: x.id});
         ctx.shoes = shoes;
         shoes.sort((a, b) => a.name.localeCompare(b.name));
         ctx.loadPartials(commonPartial).partial('./view/home.hbs')
     })
}