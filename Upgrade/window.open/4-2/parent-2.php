<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<meta name="viewport" content="width=device-width, initial-scale = 1.0, maximum-scale = 1.0, user-scalable=no">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.4/jquery.min.js"></script>
<style type="text/css">

#open-child-window-2 {
	width: 300px;
	display: block;
	margin: 40px auto 0 auto;
}

#messages-container-2 {
	max-width: 600px;
	margin: 40px auto 0 auto;
	overflow: hidden;
	display: none;
}

h6 {
	margin: 0 0 20px 0;
	text-align: center;
}

#message-to-outer-2 {
	width: 45%;
	background-color: #f8f8f8;
	padding: 5px;
	box-sizing: border-box;
	float: left;
	margin: 0 10% 0 0;
}

#message-to-container-2 {
	height: 150px;
}

#message-to-container-2 textarea {
	height: 100px;
	margin: 0 0 20px 0;
	display: block;
	box-sizing: border-box;
	width: 100%;
	resize: none;
}

#message-to-container-2 button {
	height: 30px;
	display: block;
	box-sizing: border-box;
	width: 100%;
}

#message-from-outer-2 {
	width: 45%;
	background-color: #e9e9e9;
	padding: 5px;
	box-sizing: border-box;
	float: right;
}

#message-from-container-2 {
	height: 150px;
	overflow: auto;
}

</style>
</head>

<body>

<button id="open-child-window-2">Open Child Window</button>

<div id="messages-container-2">
	<div id="message-to-outer-2">
		<h6>Send Message to Child</h6>
		<div id="message-to-container-2">
			<textarea id="message-2"></textarea>
			<button id="send-message-child-2">Send Message to Child</button>
		</div>
	</div>
	<div id="message-from-outer-2">
		<h6>Messages from Child</h6>
		<div id="message-from-container-2"></div>
	</div>
</div>

<script>

// This will hold the handle of the child window
var __CHILD_WINDOW_HANDLE_2 = null;

$("#open-child-window-2").on('click', function() {
	__CHILD_WINDOW_HANDLE_2 = window.open('http://vaynelabs.com/mics/child-2.php', '_blank', 'width=700,height=500,left=200,top=100');

	$("#messages-container-2").show();
	$("#open-child-window-2").hide();
});

$("#send-message-child-2").on('click', function() {
	if($.trim($("#message-2").val()) != '') {
		__CHILD_WINDOW_HANDLE_2.postMessage($("#message-2").val(), "*");
		$("#message-2").val('');
	}
});

window.addEventListener('message', function(e) {
	ProcessChildMessage_2(e.data);
} , false);

function ProcessChildMessage_2(message) {
	$("#message-from-container-2").append('<div>' + message + '</div>');
}

</script>

</body>
</html>