function solve(arr) {

    let obj = {};

    for (let i = 0; i < arr.length; i+=2) {
       
        const key = arr[i];
        const value = arr[i + 1];

        obj[key] = Number(value);
    }
    
    console.log(obj);
}