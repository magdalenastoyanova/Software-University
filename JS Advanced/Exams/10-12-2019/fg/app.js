function solution() {
    let input = document.querySelector('.card input');
    let addBtn = document.querySelector('.card button');
    let sections = Array.from(document.querySelectorAll('section ul'));
    let [list, sent, discard] = sections;

    addBtn.addEventListener('click', () => {
       let liEl = document.createElement('li');
       liEl.textContent = input.value;
       liEl.setAttribute('class', 'gift');     

       let sendBtn = document.createElement('button');
       sendBtn.textContent = 'Send';
       sendBtn.setAttribute('id', 'sendButton');

       let discardBtn = document.createElement('button');
       discardBtn.textContent = 'Discard';
       discardBtn.setAttribute('id', 'discardButton');
       
       liEl.appendChild(sendBtn);
       liEl.appendChild(discardBtn);

       list.appendChild(liEl);

       sortList();

       input.value = '';
       
       sendBtn.addEventListener('click', sentGifts);
       discardBtn.addEventListener('click', discardGifts);


    });
     
    function sentGifts(e) {
        let gift = e.target.parentNode.childNodes[0].textContent;
         
       e.target.parentNode.remove();

        let newLii = document.createElement('li');
        newLii.textContent = gift;
        newLii.setAttribute('class', 'gift');

        sent.appendChild(newLii);

    }
    
    function discardGifts(e) {
        let gift = e.target.parentNode.childNodes[0].textContent;
         
       e.target.parentNode.remove();

        let newLi = document.createElement('li');
        newLi.textContent = gift;
        newLi.setAttribute('class', 'gift');

        discard.appendChild(newLi);

    }
    function sortList() {
        Array.from(list.querySelectorAll('li'))
            .sort((a, b) => a.textContent.localeCompare(b.textContent))
            .forEach(li => list.appendChild(li));
    }
}