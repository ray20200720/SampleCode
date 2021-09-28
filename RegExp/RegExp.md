# 常見的應用案例
## Visual Studio Code
- Ctrl + f  
    搜尋 
        (\d)
    取代 
        $1$1
    結果
        1 -> 11
        2 -> 22
        3 -> 33

- </?div>
    可找出<div></div>

## Power Rename(批次變更檔名)

https://docs.microsoft.com/zh-tw/windows/powertoys/install

https://github.com/microsoft/PowerToys

## TortoiseGit用來搜尋Log訊息

# 正則表達式基本語法介紹-字元,次數,Flag等等
https://regex101.com/

https://regexone.com/

https://leetcode.com/playground/74RFEgWY

https://developer.mozilla.org/zh-TW/docs/Web/JavaScript/Guide/Regular_Expressions

https://zh.wikipedia.org/wiki/%E6%AD%A3%E5%88%99%E8%A1%A8%E8%BE%BE%E5%BC%8F

正則圖形化 https://regexper.com/

https://regexcrossword.com

教學文章:
1. https://www.fooish.com/regex-regular-expression/groups-lookaround.html
2. https://www.regular-expressions.info/refcapture.html
3. https://github.com/ziishaned/learn-regex/blob/master/translations/README-cn.md
4. https://5xruby.tw/posts/15min-regular-expression
5. https://dailc.github.io/2017/07/06/regularExpressionGreedyAndLazy.html

## Pattern & Flag

/^\d{3}$/gm
^開頭
$結尾
\d{3} 3個數字

## 特殊字元
[]  ex: [abc]   --> 找a 或 b 或 c                       --> a b c d(x)
[^] ex: [^abc]  --> 找abc以外的                         --> a(x) b(x) c(x) d
^   ex: ^a      --> 找a開頭的                           --> ab  cd(x)
$   ex: a$      --> 找a結尾的                           --> ab(x) ba a cat(x) 
+   ex: a+      --> One or more of a                   --> a aa aabaa 
*   ex: a*      --> Zero or more of a                  --> a ab abb abba
?   ex: ab?     --> 必須有a,b可有可無.但最多1個字元      --> a ab abb abbb 
{n, m}  ex: {2,3}   --> 匹配2個字元~3個字元             --> ap{2,3}
        ex: {2,}    --> 匹配2個字元~無限多
|   ex: a|b        
\   ex: \/

## 字元集合
.   Any single character
\w  匹配任意字符 相當於 [a-zA-Z0-9_]
\W  匹配任意非字符 matches any non-word character (equivalent to [^a-zA-Z0-9_])
\d  Any digit
\D  Any non-digit
\s  Any whitespace character        匹配空白字元包含\r\n\t等 (equivalent to [\r\n\t\f\v])
\S  Any non-whitespace character    匹配非空白字元包含\r\n\t等   (equivalent to[^\r\n\t\f\v])

## flag
g   global:全域模式                 g會匹配多個. 未設定g則當找到第一個符合的就不會往下找 
m   multiline:多行模式              m每一行都會匹配. 未設定m則全部視為一行              測試Pattern: ^|$
i   case insensitive:忽略大小寫
s   singleline:單行模式

## group用法介紹-capturing group (匹配群組)
/^(\d)\d{3}$/gi

使用()就是capturing group

<span class="my">

/<[a-z]+\s+[^>]+>/
/<(([a-z]+)\s+([^>]+))>/

var str = '<span class="my">'
var pattern = /<(([a-z]+)\s+([^>]+))>/;
var result = str.match(pattern);

## shy group  (?:pattern)

var str = '<span class="my">'
var pattern = /<((?:[a-z]+)\s+([^>]+))>/;

在已經用()分的group裡面加上?: 會取消那個group

## BackReferences

var str = 'abc=abc,def=def,abc=def,def=abc';
var pattern = /(abc|def)=\1/g;
var result = str.match(pattern);    // 'abc=abc'
                                    // 'def=def'

## 不同情境下的BackReferences表示法
- 正則內使用:   \1
    ex:
        var str = 'abc=abc,def=def,abc=def,def=abc';
        var pattern = /(abc|def)=\1/g;
        str.match(patter).forEach(m=>console.log(m));   // abc=abc
                                                        // def=def
        
- 替換內使用:   $1
    ex:
        var str = 'abc=abc,def=def,abc=def,def=abc';
        var pattern = /(abc|def)=\1/g;
        var replace = "xx$1xx";
        console.log(str.replace(pattern, replace));     // xxabcxx,xxdefxx,abc=def,def=abc

## Lookaround (左右合樣) 

https://blog.miniasp.com/post/2008/05/09/Using-Regular-Expression-to-validate-password

- Positive Lookahead
    Pattern     Description            TestCase (O)   (x)
    a(?=b)      找a後面接b,但不找b       ab             ac
- Negative  Lookahead
    a(?!b)      找a後面不接b             aa            ab 
                                        ac             
- Positive Lookbehind
    (?<=b)a     找a前面是b               ba            aa, ab, ac, ba, bb, bc, ca, cb, cc
- Negative Lookbehind
    (?<!b)a     找a前面不是b             aa, ab, ac, ca          ba, bb, bc, cb, cc

## greedy mode (貪婪模式)
貪婪模式            非貪婪模式
+                   +?
?                   ??
*                   *?
{n}                 {n}?
{n,}                {n,}?
{n,m}              {n,m}?

- 貪婪模式實例1: 比對符合之後還會繼續比對
var str = 'aacbacbc';
var pattern = /a.*b/;
var result = str.match(pattern);  //aacbacb

- 非貪婪模式實例: 比對符合之後就停止比對
var str = 'aacbacbc';
var pattern = /a.*?b/;
var result = str.match(pattern);  //aacb

- 實例2: 
\/\/[^'"]*$
\/\/[^'"]*?$

000
// 111
222
// 333
444
// 555
666

## 實戰
- Case 1:
https://www.google.com
http://test.com
https://youtube.com
https://www.nasa.gov

Pattern:
https?\/\/(www\.)?(\w+)(\.\w+)

- Case 2:
xxxx.com/api/foo/report/bar
xxxx.com/api/123/report/456
http://localhost:5678/api/xxx/report/yyy
http://localhost:1234/api/456/report/123

Pattern:
api\/(\w+)\/report\/(\w+)
(?<=(?:api|report)\/)\w+

- Case 3:
2021/1/1
2021/01/01
2021-02-02
2021-10-9
2021/2-2
2021-3/3

Pattern:
\d{4}(\/|-)\d{1,2}\1\d{1,2}

- Case 4:
0912345678
886912345678
+886912345678
++886912345678
912345678
+0912345678
8860912345678
886912456
886812345678
88685299
882556666
123+886912345678
120912345678

Pattern:
^(0|\+?886)9\d{8}$

## 測試數據
ant
api
apple
appp
apppp
apppppppppppppp
book
clear
cat 
car
dog
elephant
0928111222
Kuo.Ray@invente.com
https://www.google.com
https:///www.google.com
wwww.google.com





