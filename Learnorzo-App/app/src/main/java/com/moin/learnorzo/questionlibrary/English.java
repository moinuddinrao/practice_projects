package com.moin.learnorzo.questionlibrary;

public class English {
    private String Questions [] = {
            "I am as busy as _____.",
            "The students are __________ their notes.",
            "I will see you _____ Saturday.",
            "Aantonym for 'Polite' is",
            "_________ spend most of their time on research."

    };

    private String Choices [][] = {
            {"bat", "bee", "butterfly", "beaver"},
            {"wrote", "written", "writing", "write"},
            {"to", "on", "at", "in"},
            {"Crazy", "Angry", "Irritable", "Rude"},
            {"Scientists", "Scintist", "Scintests", "Scienntists"},

    };

    private String CorrectAnswers[] = {"beaver","writing", "on", "Rude", "Scientists"};

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
