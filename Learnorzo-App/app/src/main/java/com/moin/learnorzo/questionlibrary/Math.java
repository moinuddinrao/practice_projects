package com.moin.learnorzo.questionlibrary;

public class Math {
    private String Questions [] = {
            "The Next Primer number after 7 is",
            "Square root of 144?",
            "How many years complete a decade?",
            "_____ is the perimeter of a circle?",
            "0.75 is same as?",

    };

    private String Choices [][] = {
            {"9", "11", "13", "17"},
            {"12", "11", "24", "44"},
            {"100", "50", "1000", "10"},
            {"Square", "Circumference", "Pie", "Parallel"},
            {"7.5%", "0.75%", "75%", "0.075%"},

    };

    private String CorrectAnswers[] = {"11","12", "10", "Circumference", "75%"};

    public String getQuestion(int a) {
        String question = Questions[a];
        return question;
    }


    public String getChoice1(int a) {
        String choice0 = Choices[a][0];
        return choice0;
    }


    public String getChoice2(int a) {
        String choice1 = Choices[a][1];
        return choice1;
    }

    public String getChoice3(int a) {
        String choice2 = Choices[a][2];
        return choice2;
    }

    public String getChoice4(int a) {
        String choice2 = Choices[a][3];
        return choice2;
    }

    public String getCorrectAnswer(int a) {
        String answer = CorrectAnswers[a];
        return answer;
    }

}
