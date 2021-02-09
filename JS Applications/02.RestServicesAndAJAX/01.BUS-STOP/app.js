function getInfo() {
    let stopId = document.getElementById('stopId');
    let validBuses = ['1287', '1308', '1327', '2((334'];
    let stopInfo = document.getElementById('stopName');
    let busesList = document.getElementById('buses'); //ul

    if(!validBuses.includes(stopId.value)){
        stopInfo.textContent = 'Error';
        busesList.textContent = '';
        return;
    }

    const url = `https://judgetests.firebaseio.com/businfo/${stopId.value}.json`;

     fetch(url)
     .then((response) => response.json())
     .then((data) => {
         stopInfo.textContent = data.name;
         
         Object.keys(data.buses).forEach(key => {
             let li = document.createElement('li');
             li.textContent = `Bus ${key} arrives in ${data.buses[key]} minutes`;
             busesList.appendChild(li);
         })

         stopId.value ='';
     });

     
}