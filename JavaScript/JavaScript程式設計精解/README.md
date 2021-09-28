# var和let的差異
 1. let不允許變數重複
 
 let msg = 'OKOK';
 let msg = 'HoooBa'; //Uncaught SyntaxError: Identifier 'a' has already been declared

 var msg = 'OKOK';
 var msg = 'HoooBa';

 2. 區塊範圍

 * 在ES6之後的環境開發,建議優先採用let指令

# 解構指派(陣列)

 - 以往從陣列中取出
 
 var data = [56, 40, 26, 82, 19, 17, 73, 99];
 var x0 = data[0];
 var x1 = data[1];

 - 用destructuring assignment

 let data = [56, 40, 26, 82, 19, 17, 73, 99];
 let [x0, x1, x2, x3, x4, x5, x6, x7] = data;

 - 承上,用...可以將未解構的元素,以陣列格式指派給對應的變數

 let data = [56, 40, 26, 82, 19, 17, 73, 99];
 let [x0, x1, ...other] = data

 - 在ES6以前,變數交換要透過一個暫存變數,ES6之後可以透過解構指派

 let x = 1;
 let y = 2;
 [x, y] = [y, x];

# 解構指派(物件)

 let book = { title: 'Java口袋書', publish: '技術評論社', price: 2680 };
 let { price, title, memo = 'none' } = book;

# 物件與陣列解構差異

物件透過名稱將變數分解到各變數中,因此就算與屬性定義的順序不同,或有不要分解出來的屬性(此例中的publish)都沒關係.會自動忽略.
此外,目的地的變數還可用 變數名稱 = '預設值' 的形式初始化.(此例中的memo='none')

# 更複雜的解構指派
 1. 分解子物件

 let book = { title: 'Java口袋書', publish: '技術評論社', price: 2680, other: { keywd: 'Java SE 8', logo: 'logo.jpg' }};
 let { title, other, other: { keywd } } = book;

 console.log(other); // { keywd: 'Java SE 8', logo: 'logo.jpg' }
 console.log(keywd); // 'Java SE 8'}

 2. 設定變數別名

let book = { title: 'Java口袋書', publish: '技術評論社' };
let { title: name, publish: company } = book; 

console.log(name);      // Java口袋書
console.log(company);   // 技術評論社

- 語法上宣告與指派可以寫在同一行,也可以分行撰寫.但分行撰寫須注意最前面和最後面要加上小括號(陣列不需要),
此時左邊的{}會被視為一個區塊而不是物件

let price, title, memo;                     //宣告
({ price, title, memo = 'none' } = book );  //指派

# 比較運算子 == 和 === 的差異
 
 - ==運算子比較左右兩邊的值,相等回傳true,不相等則回傳false. 當運算元的資料型別不同時,會嘗試轉換資料型別,以測試是否有別種相等的可能
  
   console.log(1 == true); // true

   var data1 = ['JavaScript', 'Ajax', 'ASP.NET' ]'
   var data2 = ['JavaScript', 'Ajax', 'ASP.NET' ]'
   console.log(data1 == data2); // false

    
    console.log('3.14E2' == 314);   // true
    console.log('0x10' == 16);      // true
    console.log('1' == 1);          // true

 - === 嚴格相等比較運算子

    console.log('3.14E2' === 314);  // false
    console.log('0x10' === 16);     // false
    console.log('1' === 1);         // false

 - 在大型的應用程式開發中,JavaScript對型別的彈性容易造成錯誤,因此在數值比較時,建議使用===嚴格相等運算子

 
    

   
