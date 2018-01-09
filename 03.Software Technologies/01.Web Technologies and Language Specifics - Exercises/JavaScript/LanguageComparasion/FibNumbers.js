function main (lines){
    let  first =1;
    let second =1;
    let n = parseInt(lines[0]);

    let result = findFib(first,second,n);

    console.log(result);

    function  findFib(first,second) {
        if (n<2) {
            return 1;
        }
        for(let i =2; i<=n; i++){
            let third = first + second;
            first =second;
            second = third;
        }

        return second;
    }
}
main(['11']);



