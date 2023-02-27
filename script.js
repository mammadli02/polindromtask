var number2;
var number3; 
var result=0;
var number=12021;
number3=number; 
while(number>0){
     number2=number%10;
    number = parseInt(number/10);
    result = result*10+number2;

}
    if(result==number3){
console.log(result+"polindrom ededdir");
    }
    else{
        console.log(result+"polindrom deyil");
    }
    




