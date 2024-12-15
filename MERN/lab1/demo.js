// 1

// const sumofnums= n =>{
//     return (n*(n+1)*(2*n+1))/6
// }
// console.log(sumofnums(10))

// 2

// let addThree=n=>{
//     sum=1
//     console.log(sum)
//     for(let i=1; i<=n;i++ )
//     {
//        console.log(sum+=3)
//     }
// }

// addThree(50)

// 3

// let oddEvenSeries=n=>{
//     sum=1
//     // console.log(sum)
//     for(let i=2; i<=n;i++ )
//     {
//        if(i%2==0)
//        {
//         sum-=i;
//        }
//        else
//        {
//         sum+=i
//        }
//     }
//     console.log(sum)
// }

// oddEvenSeries(9)

// 4
// let factorial=n=>{
//     fact=1
//     // console.log(sum)
//     for(let i=1; i<=n;i++ )
//     {
//        fact*=i
//     }
//     console.log(fact)
// }

// 5

// let factor=n=>
// {
//        for(let i=1; i<=n;i++ )
//             {
//                if(n%i===0)
//                {
//                 console.log(i)
//                }
//             }
// }

// factor(3)

// 6

// let perfect=n=>
// {
//     sum=0;
//        for(let i=1; i<n;i++ )
//             {
//                if(n%i===0)
//                {
//                 sum+=i
//                }
//             }

//             if(sum==n)
//             {
//                 console.log("perfect")
//             }
//             else
//             {
//                 console.log("not perfect")

//             }
// }

// perfect(6)

// let prime=n=>{

//     for(i=2;i<=Math.sqrt(n);i++)
//     {
//         if(n%i==0)
//         {
//             console.log("not prime")
//             return
//         }

//     }
//     console.log("prime")
// }

// prime(8)

let palindrome = (n) => {
  let str = n.toString();

  let rev = str.split("").reverse().join("");
  if (str == rev) {
    console.log("palindrome");
  } else {
    console.log("not palindrome");
  }
};
palindrome(41);

let armstrong = (n) => {
  let sum = 0;
  let str = n.toString();
  for (let i = 0; i < str.length; i++) {
    let num = parseInt(str[i]);
    sum += Math.pow(num, str.length - 1);
  }
  if (n == sum) {
    console.log("armstrong");
  } else {
    console.log("not armstrong");
  }
};

armstrong(10)

let fibonacci = n=>{
    let a=0,b=1,c=0;
    console.log(a,b)
    for(i=0;i<n;i++)
        {
            c=a+b;
            a=b;
            b=c;
            console.log(c);
        }
}
fibonacci(10)
