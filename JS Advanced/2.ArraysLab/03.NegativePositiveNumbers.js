function solve(input){

    let secondArr = [];

    for (let index = 0; index <= input.length; index++) {
       
        if(input[index] >= 0){
          
            secondArr.push(input[index])
        }
        else if(input[index] < 0){

           secondArr.unshift(input[index])
        }
    }
    console.log(secondArr);
}

solve([7, -2, 8, 9]);