function solve(input){
    
    input = input
    .sort(function (a, b) {
        return a.length - b.length || 
        a.localeCompare(b);
    })
    .forEach((x) => console.log(x));
}
