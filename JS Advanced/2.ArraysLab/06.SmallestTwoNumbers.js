function solve(arr) {
    let num1 = Math.min(...arr);

    const index = arr.indexOf(num1);
    arr.splice(index, 1);

    let num2 = Math.min(...arr);
    console.log(num1 + ' ' + num2);
}