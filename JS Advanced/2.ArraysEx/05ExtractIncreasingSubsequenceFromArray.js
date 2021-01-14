function solve(arr){

    let lastEl = Number.MIN_SAFE_INTEGER;
    for (let i = 0; i < arr.length; i++) {
        
        if(arr[i] >= lastEl){
            lastEl = arr[i];
            
            console.log(lastEl);
        }
    }
}