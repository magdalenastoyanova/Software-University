import {getHome} from './controller/home.js';
import { getCreate, getDetails, postCreate,  getEdit, postEdit, getClose, getBuy} from './controller/shoes.js';
import { getLogin, getRegister, postLogin, postRegister, getLogout } from './controller/user.js';

const app = Sammy("body", function () {
    this.use("Handlebars", "hbs");

    this.get('#/home', getHome);
    this.get('#/login', getLogin);
    this.get('#/register', getRegister);

    this.post('#/register', postRegister);
    this.post('#/login', postLogin);
    this.get('#/logout', getLogout);

    this.get('#/create', getCreate);
    this.post('#/create', postCreate);
    this.get('#/details/:id', getDetails);
 
    this.get('#/edit/:id', getEdit);
    this.post('#/edit/:id', postEdit);

    this.get('#/close/:id', getClose);
    this.get('#/buy/:id', getBuy);

});

app.run('#/home');