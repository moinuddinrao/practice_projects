package com.moin.learnorzo.questionlibrary;

public class Science {

    private String Questions [] = {
            "Which animal lays eggs?",
            "A male cow is called?",
            "What is Earth’s only natural satellite?",
            "If one boils water it will convert into _____.",
            "Which is the largest animal on earth?"

    };

    private String Choices [][] = {
            {"Dog", "Cat", "Duck", "Sheep"},
            {"Ox", "Dog", "Sheep", "Monkey"},
            {"Sun", "Mars", "Venus", "Moon"},
            {"Mist", "Steam", "Cloud", "Snow"},
            {"Shark", "Elephent", "Blue Whale", "Giraffe"},

    };

    private String CorrectAnswers[] = {"Duck", "Ox", "Moon", "Steam", "Blue Whale"};

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