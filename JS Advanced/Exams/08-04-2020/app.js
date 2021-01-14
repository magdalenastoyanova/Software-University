function solve() {
    let taskInput = document.getElementById('task');
    let descrInput = document.getElementById('description');
    let dueDateInput = document.getElementById('date');
    let sections = document.querySelectorAll('section');
    let openDiv = sections.item(1).querySelectorAll('div').item(1);
    let progressDiv = sections.item(2).querySelectorAll('div').item(1);
    let finishedDiv = sections.item(3).querySelectorAll('div').item(1);
  
    
  
    let addBtn = document.getElementById('add');
    addBtn.addEventListener('click', addTask);
  
    function addTask(e){
        e.preventDefault();
  
        if(taskInput.value.length > 0 && descrInput.value.length > 0 && dueDateInput.value.length > 0){
        
      let newTask = document.createElement('article');
  
      let nameTask = document.createElement('h3');
      nameTask.textContent = taskInput.nodeValue;
  
      let newDescr = document.createElement('p');
      newDescr.textContent = `Description: ${descrInput.value}`;
  
      let newDate = document.createElement('p');
      newDate.textContent = `Due Date: ${dueDateInput.value}`;
  
      let divElement = document.createElement('div');
      divElement.setAttribute('class', 'flex');
  
      let startBtn = document.createElement('button');
      startBtn.setAttribute('class', 'green');
      startBtn.textContent = 'Start';
  
      let deleteBtn = document.createElement('button');
      deleteBtn.setAttribute('class', 'red');
      deleteBtn.textContent = 'Delete';
  
      divElement.appendChild(startBtn);
      divElement.appendChild(deleteBtn);
  
      newTask.appendChild(nameTask);
      newTask.appendChild(newDescr);
      newTask.appendChild(newDate);
      newTask.appendChild(divElement);
  
      openDiv.appendChild(newTask);
  
        taskInput.value = '';
        descrInput.value = '';
        dueDateInput.value = '';
      
  }
     
     startBtn.addEventListener('click', inProgress);
  
     function inProgress(e){
      openDiv = '';
  
      let newArticle = document.createElement('article');
  
         let newTitle = document.createElement('h3');
         newTitle.textContent = taskInput.value;
  
         let newP = document.createElement('p');
         newP.textContent = `Description: ${descrInput.value}`;
  
         let pDate = document.createElement('p');
         pDate.textContent = `Due Date: ${dueDateInput.value}`;
  
         let divElement = document.createElement('div');
         divElement.setAttribute('class', 'flex');
  
         let deleteBtn = document.createElement('button');
         deleteBtn.setAttribute('class', 'red');
         deleteBtn.textContent = 'Delete';
  
         let finishBtn = document.createElement('button');
         finishBtn.setAttribute('class', 'orange');
         finishBtn.textContent = 'Finish';
  
         divElement.appendChild(deleteBtn);
         divElement.appendChild(finishBtn);
  
         newArticle.appendChild(newTitle);
         newArticle.appendChild(newP);
         newArticle.appendChild(pDate);
         newArticle.appendChild(divElement);
  
         progressDiv.appendChild(newArticle);
  
         taskInput.value = '';
         descrInput.value = '';
         dueDateInput.value = '';
     }
    
     }
     deleteBtn.addEventListener('click', deleteTask);
  
     function deleteTask(e){
         e.target.parentNode.parentNode.remove();
     }
  
     finishBtn.addEventListener('click', finishTask);
  
     function finishTask(){
        inProgress = '';
        let lastArticle = document.createElement('article');
        
        let pLast = document.createElement('p');
        pLast.textContent = `Description: ${descrInput.value}`;
  
        let pLast2 = document.createElement('p');
        pLast2.textContent = `Due date: ${dueDateInput.value}`;
        
         lastArticle.appendChild(pLast);
         lastArticle.appendChild(pLast2);
  
         finishedDiv.appendChild(lastArticle);
     }
  }
  