const expect = require('chai').expect;

function isOddOrEven(string) {
    if (typeof(string) !== 'string') {
        return undefined;
    }
    if (string.length % 2 === 0) {
        return "even";
    }

    return "odd";
}
describe('Odd or Even', () => {
    it('shoild return odd', () => {
        expect(isOddOrEven('aaa')).to.equal('odd');
    });
    it('should return even', () => {
        expect(isOddOrEven('tttt')).to.equal('even');
    });
    it('should return undefined for non-strings', () =>{
       expect(isOddOrEven(5)).to.equal(undefined);
       expect(isOddOrEven([])).to.equal(undefined);
       expect(isOddOrEven({})).to.equal(undefined);

    });
});
