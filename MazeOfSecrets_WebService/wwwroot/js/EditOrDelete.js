var lastId;

var requestOptions =
{
    method: 'GET',
    redirect: 'follow'
};

fetch("http://localhost:63489/api/MazeDataItems/GetCount", requestOptions)
    .then(response => response.text())
    .then(result => processResult(result))
    .catch(error => console.log('error', error));


function processResult(res) {
    var jsonData = JSON.parse(res);

    console.log(jsonData);

    lastId = jsonData;

    if (jsonData == 0)
        return;

    var select = document.getElementById("id");
    for (var i = jsonData; i > 0; --i) {
        var option = document.createElement('option');
        option.text = option.value = i;

        if (i == 1)
            option.selected = true;

        select.add(option, 0);
    }

    var requestOptions = {
        method: 'GET',
        redirect: 'follow'
    };

    fetch("http://localhost:63489/api/MazeDataItems/" + select.value, requestOptions)
        .then(response => response.text())
        .then(result => doInserts(result))
        .catch(error => console.log('error', error));
}

function getval(sel) {
    var requestOptions = {
    method: 'GET',
        redirect: 'follow'
    };

    fetch("http://localhost:63489/api/MazeDataItems/" + sel.value, requestOptions)
        .then(response => response.text())
        .then(result => doInserts(result))
        .catch(error => console.log('error', error));
}

function doInserts(res) {
    var jsonData = JSON.parse(res);

    console.log(jsonData);


    var userId = document.getElementById("userId");
    var question = document.getElementById("question");
    var correctAnswer = document.getElementById("corrAnswer");
    var wrongAnswer1 = document.getElementById("wrongAns1");
    var wrongAnswer2 = document.getElementById("wrongAns2");

    userId.value = jsonData.userId;
    question.innerHTML = jsonData.question;
    correctAnswer.innerHTML = jsonData.correctAnswer;
    wrongAnswer1.innerHTML = jsonData.wrongAnswer1;
    wrongAnswer2.innerHTML = jsonData.wrongAnswer2;
}

window.onload = function () {

};

function EditQuiz() {
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

    var myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");

    var raw = JSON.stringify({
        "id": quizId,
        "userId": userId,
        "question": question,
        "correctAnswer": correctAnswer,
        "wrongAnswer1": wrongAnswer1,
        "wrongAnswer2": wrongAnswer2
    });

    var requestOptions = {
        method: 'PUT',
        headers: myHeaders,
        body: raw,
        redirect: 'follow'
    };

    fetch("http://localhost:63489/api/MazeDataItems/" + quizId, requestOptions)
        .then(response => response.text())
        .then(result => console.log(result))
        .catch(error => console.log('error', error));

    location.reload();
}

function DeleteLast()
{
    var formdata = new FormData();

    var requestOptions = {
        method: 'DELETE',
        body: formdata,
        redirect: 'follow'
    };

    fetch("http://localhost:63489/api/MazeDataItems/" + lastId, requestOptions)
        .then(response => response.text())
        .then(result => console.log(result))
        .catch(error => console.log('error', error));

    location.reload();
}

function DeleteAll() {
    var requestOptions = {
        method: 'DELETE',
        redirect: 'follow'
    };

    fetch("http://localhost:63489/api/MazeDataItems/DeleteAllItems", requestOptions)
        .then(response => response.text())
        .then(result => console.log(result))
        .catch(error => console.log('error', error));

    location.reload();
}