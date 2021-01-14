function solve(num){

    let typeOfArgument = typeof(num);
    let result;

    if(typeOfArgument === 'number'){
        result = Math.pow(num, 2) * Math.PI;

        console.log(result.toFixed(2));
    }
    else{

       console.log(`We can not calculate the circle area, because we receive a ${typeOfArgument}.`) 
    }

}