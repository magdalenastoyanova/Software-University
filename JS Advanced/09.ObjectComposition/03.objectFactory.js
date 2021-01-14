function objectFactory(input){

    let result = input.map(([text , num]) =>({
        text,
        num
    }))
    .reduce((a, x) => ({...a, ...x}), {});

     return result;
}