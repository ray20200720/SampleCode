<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<meta name="viewport" content="width=device-width, initial-scale = 1.0, maximum-scale = 1.0, user-scalable=no">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.4/jquery.min.js"></script>
<style type="text/css">

#messages-container {
	width: 600px;
	margin: 40px auto 0 auto;
	overflow: hidden;
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

<div id="messages-container">
	<div id="message-to-outer">
		<h6>Send Message to Parent</h6>
		<div id="message-to-container">
			<textarea id="message"></textarea>
			<button id="send-message-parent">Send Message to Parent</button>
		</div>
	</div>
	<div id="message-from-outer">
		<h6>Messages from Parent</h6>
		<div id="message-from-container"></div>
	</div>
</div>

<script>

$("#send-message-parent").on('click', function() {
	if($.trim($("#message").val()) != '') {
		window.opener.ProcessChildMessage($("#message").val());
		$("#message").val('');
	}
});

function ProcessParentMessage(message) {
	$("#message-from-container").append('<div>' + message + '</div>');
}

</script>

</body>
</html>