function notify(message) {
    
    let newDivElement = document.getElementById('notification');
    newDivElement.textContent = message;
    newDivElement.style.display = 'block';

    setTimeout(() => {
        
        newDivElement.style.display = 'none';
    }, 2000);
}