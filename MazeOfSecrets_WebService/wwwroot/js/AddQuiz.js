
var requestOptions = {
    method: 'GET',
        redirect: 'follow'
    };

    fetch("http://localhost:63489/api/MazeDataItems/GetCount", requestOptions)
        .then(response => response.text())
        .then(result => doWork(result))
        .catch(error => console.log('error', error));

    function doWork(res) {
        var jsonData = JSON.parse(res);

        console.log(jsonData);

        var idEdit = document.getElementById("id");

        idEdit.value = jsonData + 1;
    }

    window.onload = function () {

};

    function PostNewQuiz() {
        var myHeaders = new Headers();
        myHeaders.append("Content-Type", "application/json");

        var quizId = +document.getElementById("id").value;
        var userId = +document.getElementById("userId").value;
        var question = document.getElementById("question").value;
        var correctAnswer = document.getElementById("corrAnswer").value;
        var wrongAnswer1 = document.getElementById("wrongAns1").value;
        var wrongAnswer2 = document.getElementById("wrongAns2").value;

        if (document.getElementById("userId").value.toString().length < 1 || question.toString().length < 1 || correctAnswer.toString().length < 1 ||
            wrongAnswer1.toString().length < 1 || wrongAnswer2.toString().length < 1) {
            document.getElementById("warningLabel").innerHTML = "Please fill all inputs";
            return;
        }

        var raw = JSON.stringify({
            "id": +quizId,
            "userId": +userId,
            "question": question,
            "correctAnswer": correctAnswer,
            "wrongAnswer1": wrongAnswer1,
            "wrongAnswer2": wrongAnswer2
        });

        console.log("id: " + +quizId);

        var requestOptions =
        {
            method: 'POST',
            headers: myHeaders,
            body: raw,
            redirect: 'follow'
        };

        console.log(raw);

        fetch("http://localhost:63489/api/MazeDataItems/addItem", requestOptions)
            .then(response => response.text())
            .then(result => console.log(result))
            .catch(error => console.log('error', error));

        location.reload();
    }