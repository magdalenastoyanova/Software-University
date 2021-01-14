function solve(arr1, arr2, arr3){
    let sum;
    let average;

    let first = arr1.length;
    let second = arr2.length;
    let third = arr3.length;

    sum = first + second + third;
    average = Math.floor(sum/3);

    console.log(sum);
    console.log(average);
 }