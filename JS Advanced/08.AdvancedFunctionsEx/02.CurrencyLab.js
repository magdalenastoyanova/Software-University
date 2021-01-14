function result(x) {
    const obj = {
      separator: ',',
      symbol: '$',
      symbolFirst: true,
    };
   
    const format = (y) => x(...Object.values(obj), y);
   
    return format;
  }