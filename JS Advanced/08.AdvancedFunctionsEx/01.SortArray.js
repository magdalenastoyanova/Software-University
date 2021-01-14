function sortArray(numbers, command){

if(command == 'asc'){
    return numbers.sort((a, b) => a - b);
} else if(command == 'desc'){
    return numbers.sort((a,b) => b - a);
}

}