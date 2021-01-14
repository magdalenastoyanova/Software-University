function pressHouse(){
   
    class Article{
    constructor(title, content){
    this.title = this.title;
    this.content = this.content;
    }
    toString(){
        return `Title: ${this.title}` + '\n' + `Content: ${this.content}`;        
    }
  }
   
   class ShortReports extends Article{
    constructor(title, content, originalResearch){
        super(title, content);
        this.originalResearch = {
            title,
            author
        };
        this.comments = [];

        if(content.length > 150){
            return 'Short reports content should be less then 150 symbols.';
        }
        if(!originalResearch.title || !originalResearch.author){
             throw new Error('The original research should have author and title.');
        }
    }
    addComment(comment){
        this.comments.push(comment);
        return 'The comment is added.';
    }
    toString(){
       if(this.comments.length > 0){
        this.comments.unshift('\n' + 'Comments:');
       }
       return `${`${super.toString()}` + '\n'}${`Original Research: ${this.originalResearches.title} by   
         ${this.originalResearches.author}`.trim()}${'\n'.trim()}${this.comments.join('\n')}`;
    }
   }
class BookReview extends Article{
    constructor(title, content, book){
       super(title, content);
       this.book = {
           name,
           author
       };
       this.clients = [];
    }
    addClient(clientName, orderDescription){
        let client = {};
        if(this.clients.find(((c) => c.clientName == clientName) && ((c) => c.orderDescription == orderDescription))){
           throw new Error('This client has already ordered this review.');
        }else{
        this.clients.push(client = { clientName, orderDescription});
        return `${client.clientName} has ordered a review for ${this.book.name}`;
        }
    }
    toString() {
        let printOrders = '';
        if (this.clients.length != 0) {
          printOrders += 'Orders:' + '\n';
        }
        for (let i = 0; i < this.clients.length; i++) {
          printOrders += `${this.clients[i].clientName} - ${this.clients[i].orderDescription}` + '\n';
        }
        return `${`${super.toString()}` + '\n' + `Book: ${this.book.name}`}${'\n'.trim()}${`${printOrders}`.trim()}`;
        
      }

    }

    return{
        Article,
        ShortReports,
        BookReview,
    };

}