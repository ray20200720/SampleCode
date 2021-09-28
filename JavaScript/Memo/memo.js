var content = document.getElementById('content');
var date = document.getElementById('date');
var time = document.getElementById('time');
var addBtn = document.getElementById('addBtn');
var deleteBtn = document.getElementById('deleteBtn');
var list = document.getElementById('list');

//var d = new Date();
//document.getElementById("date").value = "2021-09-23";

var listContent = [];

addBtn.addEventListener('click', function(){
    
    console.log(content.value);
    console.log(date.value);
    console.log(time.value);

    listContent.push({
        content: content.value,
        date: date.value,
        time: time.value
    })
    display();
});

deleteBtn.addEventListener('click', function() {
    listContent.pop();
    display();
})

function display(){
    let htmlstr = '';

    listContent.forEach(function(item, index){
        htmlstr = htmlstr + `
            <div>
                <div>
                    <p>內容: ${item.content}</p>
                    <p>時間: ${item.date} ${item.time}</p>
                    <hr>
                </div>
            </div>
        `
    })
    list.innerHTML = htmlstr;
}
