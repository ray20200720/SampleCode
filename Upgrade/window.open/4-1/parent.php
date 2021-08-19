<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<meta name="viewport" content="width=device-width, initial-scale = 1.0, maximum-scale = 1.0, user-scalable=no">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.4/jquery.min.js"></script>
<style type="text/css">

#open-child-window {
	width: 300px;
	display: block;
	margin: 40px auto 0 auto;
}

#messages-container {
	max-width: 600px;
	margin: 40px auto 0 auto;
	overflow: hidden;
	display: none;
}

h6 {
	margin: 0 0 20px 0;
	text-align: center;
}

#message-to-outer {
	width: 45%;
	background-color: #f8f8f8;
	padding: 5px;
	box-sizing: border-box;
	float: left;
	margin: 0 10% 0 0;
}

#message-to-container {
	height: 150px;
}

#message-to-container textarea {
	height: 100px;
	margin: 0 0 20px 0;
	display: block;
	box-sizing: border-box;
	width: 100%;
	resize: none;
}

#message-to-container button {
	height: 30px;
	display: block;
	box-sizing: border-box;
	width: 100%;
}

#message-from-outer {
	width: 45%;
	background-color: #e9e9e9;
	padding: 5px;
	box-sizing: border-box;
	float: right;
}

#message-from-container {
	height: 150px;
	overflow: auto;
}

</style>
</head>

<body>

<button id="open-child-window">Open Child Window</button>

<div id="messages-container">
	<div id="message-to-outer">
		<h6>Send Message to Child</h6>
		<div id="message-to-container">
			<textarea id="message"></textarea>
			<button id="send-message-child">Send Message to Child</button>
		</div>
	</div>
	<div id="message-from-outer">
		<h6>Messages from Child</h6>
		<div id="message-from-container"></div>
	</div>
</div>

<script>

// This will hold the handle of the child window
var __CHILD_WINDOW_HANDLE = null;

$("#open-child-window").on('click', function() {
	__CHILD_WINDOW_HANDLE = window.open('child.php', '_blank', 'width=700,height=500,left=200,top=100');

	$("#messages-container").show();
	$("#open-child-window").hide();
});

$("#send-message-child").on('click', function() {
	if($.trim($("#message").val()) != '') {
		__CHILD_WINDOW_HANDLE.ProcessParentMessage($("#message").val());
		$("#message").val('');
	}
});

function ProcessChildMessage(message) {
	$("#message-from-container").append('<div>' + message + '</div>');
}

</script>

</body>
</html>