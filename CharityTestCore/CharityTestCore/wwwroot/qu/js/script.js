let index =0;
let qu = 1;
let attempt = 0;
let score = 0;
let wrong = 0;
let totalQuestions = 95;
let questions = quiz;
var formData = [{ id: 0, name: 0 }];

$(function(){
    
    // Timer code

    let totalTime = 200;  //200 seconds total
    let min = 0;
    let sec = 0;
    let counter = 0;

    let timer = setInterval( function(){
        counter++;
        min = Math.floor( (counter)/ 60) //calculating minutes
        sec = (counter % 60)  //calculating seconds

        // display on screen
        $(".timerBox span").text(min +" : "+sec)


    }, 1000); //Counter set for 1 sec interval
    // Timer code

    // Print Questions
    printQusetions(index);
});

// Function to Print Questions

function printQusetions(i){
    // console.log(quiz[i]);

    $(".questionBox").text(questions[i].question)
    $(".optionBox span").eq(0).text(questions[i].option[0])
    $(".optionBox span").eq(1).text(questions[i].option[1])
    $(".optionBox span").eq(2).text(questions[i].option[2])
    $(".optionBox span").eq(3).text(questions[i].option[3])
}

function generateRan(){
    var max = 4;
    var random = [];
    for(var i = 0;i<max ; i++){
        var temp = Math.floor(Math.random()*max);
        if(random.indexOf(temp) == -1){
            random.push(temp);
        }
        else
         i--;
    }
    return random;
}
// Function to Print Questions


// Function to check Answer

function checkAnswer(option){
    attempt++;

    let optionClicked = $(option).data("opt");

        $(option).addClass("correct");
        score++;

    formData.push({ id: qu++, name: optionClicked });
  
  /*  formData.push("1", "4");*/
    /*    $(".s" + qu++).val(optionClicked);*/
/*    console.log(formData);*/
  /*  $(".scoreBox span").text((score * 10))*/
    $(".optionBox span").attr("onclick", "") // prevent selecting a different answer

    setTimeout(function() {
        showNext();
    },300);
}

// Function to check Answer

// Show next Question
let num = 1
function showNext(){
    if(index <= 93)
    {
        console.log(index);
        index++;
        num++;
        // console.log(num);
        printQusetions(index);
        $(".con button").eq(0).removeClass("disabled")
        $(".optionBox span").removeClass();
        $(".optionBox span").attr("onclick", "checkAnswer(this)")
        $(".count span").text(num)

  
    }
    else{
        setTimeout(function() {
            showResult(0);
        },500);
    }
}


function showResult(j){
    if(
        j == 1 && num < 95 && 
        !confirm("Quiz has not finished. Press OK to skip quiz and show results.")
    ){
        return;
    }
    result();
}
function result()
{
        // questionScreen.style.display = "none";
        $("#totalQuestion").text(totalQuestions)
        $("#questionScreen").hide()
        $(".scoreBoard span").text((score * 10))
        $("#resultScreen").show()
        $("#attemptQuestion").text(attempt)
        $("#correctQuestion").text(score)
        $("#wrongAnswers").text(wrong)
        // resultScreen.style.display = "block";
}
// Show Final Result