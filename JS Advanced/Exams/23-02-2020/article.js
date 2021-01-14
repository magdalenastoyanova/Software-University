class Article {
    constructor(title, creator) {
        this.title = title;
        this.creator = creator;
 
        this._comments = [];
        this._likes = [];
    }
 
    get likes() {
        if (this._likes.length === 0) {
            return `${this.title} has 0 likes`;
        }
        else if (this._likes.length === 1) {
            return `${this._likes[0]} likes this article!`;
        }
 
        return `${this._likes[0]} and ${this._likes.length - 1} others like this article!`;
    }
 
    like = function (username) {
 
        let userExist = this._likes.find(x => x === username);
 
        if (userExist) {
            throw Error("You can't like the same article twice!");
        }
 
        if (username === this.creator) {
 
            throw Error("You can't like your own articles!");
        }
 
        this._likes.push(username);
 
        return `${username} liked ${this.title}!`;
    }
 
    dislike = function (username) {
        let user = this._likes.find(x => x === username);
 
        if (!user) {
            throw Error("You can't dislike this article!");
        }
 
        const index = this._likes.indexOf(username);
        this._likes.splice(index, 1);
 
        return `${username} disliked ${this.title}`;
    }
 
    comment = function (username, content, id) {
 
        let currentComment = this._comments.find(x => x.id === id);
        if (id === undefined || !currentComment) {
 
            let comment = {
                username,
                content,
                id: this._comments.length + 1,
                'replies': [],
            }
 
            this._comments.push(comment);
 
            return `${username} commented on ${this.title}`;
        }
 
        let reply = {
            id: `${currentComment.id}.${currentComment.replies.length + 1}`,
            username,
            content,
        }
        currentComment['replies'].push(reply)
 
        return 'You replied successfully';
    }
 
    toString = function (sortingType) {
 
        let sortFunctions = {
            'asc': (a, b) => { return a.id - b.id },
            'desc': (a, b) => { return b.id - a.id },
            'username': (a, b) => { return a.username.localeCompare(b.username) },
        }
 
        let sortTypeFunction = sortFunctions[sortingType];
 
        let resultString = `Title: ${this.title}\nCreator: ${this.creator}\nLikes: ${this._likes.length}\nComments:\n`;
 
        let sortedComments = this._comments.slice().sort(sortTypeFunction);
 
        for (const comment of sortedComments) {
 
            resultString += `-- ${comment.id}. ${comment.username}: ${comment.content}\n`;
 
            let sortedReplies = comment.replies.sort(sortTypeFunction);
 
            for (const rep of sortedReplies) {
 
                resultString += `--- ${rep.id}. ${rep.username}: ${rep.content}\n`;
            }
        }
 
        return resultString.trim();
    }
}