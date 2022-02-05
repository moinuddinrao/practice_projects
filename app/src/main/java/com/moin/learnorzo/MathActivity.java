package com.moin.learnorzo;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;
import android.widget.Toast;

import com.moin.learnorzo.questionlibrary.Math;

public class MathActivity extends AppCompatActivity {

    private Math math = new Math();

    private TextView ScoreView;
    private TextView QuestionView;
    private Button ButtonChoice1;
    private Button ButtonChoice2;
    private Button ButtonChoice3;
    private Button ButtonChoice4;
    private ImageButton ButtonBack;
    private Button ButtonSkip;

    private String Answer;
    private int Score = 0;
    private int QuestionNumber = 0;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_math);

        ButtonBack = (ImageButton)findViewById(R.id.Back);
        ScoreView = (TextView)findViewById(R.id.Score);
        QuestionView = (TextView)findViewById(R.id.Question);
        ButtonChoice1 = (Button)findViewById(R.id.choice1);
        ButtonChoice2 = (Button)findViewById(R.id.choice2);
        ButtonChoice3 = (Button)findViewById(R.id.choice3);
        ButtonChoice4 = (Button)findViewById(R.id.choice4);
        ButtonSkip = (Button)findViewById(R.id.Skip);

        updateQuestion();

        //Start of Button Listener for Back Button
        ButtonBack.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){
                Intent intent = new Intent(MathActivity.this, MainActivity.class);
                startActivity(intent);
            }
        });

        //End of Button Listener for Back Button

        //Start of Button Listener for Button1
        ButtonChoice1.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){

                if (ButtonChoice1.getText() == Answer){
                    Score = Score + 1;
                    updateScore(Score);
                    updateQuestion();

                    Toast.makeText(MathActivity.this, "correct", Toast.LENGTH_SHORT).show();

                }else {
                    Toast.makeText(MathActivity.this, "wrong", Toast.LENGTH_SHORT).show();
                    updateQuestion();
                }
            }
        });

        //End of Button Listener for Button1

        // Start of Button Listener for Button2
        ButtonChoice2.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){

                if (ButtonChoice2.getText() == Answer){
                    Score = Score + 1;
                    updateScore(Score);
                    updateQuestion();

                    Toast.makeText(MathActivity.this, "correct", Toast.LENGTH_SHORT).show();

                }else {
                    Toast.makeText(MathActivity.this, "wrong", Toast.LENGTH_SHORT).show();
                    updateQuestion();
                }
            }
        });

        //End of Button Listener for Button2

        // Start of Button Listener for Button3
        ButtonChoice3.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){
                //My logic for Button goes in here

                if (ButtonChoice3.getText() == Answer){
                    Score = Score + 1;
                    updateScore(Score);
                    updateQuestion();

                    Toast.makeText(MathActivity.this, "correct", Toast.LENGTH_SHORT).show();

                }else {
                    Toast.makeText(MathActivity.this, "wrong", Toast.LENGTH_SHORT).show();
                    updateQuestion();
                }
            }
        });

        //End of Button Listener for Button4

        // Start of Button Listener for Button4
        ButtonChoice4.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){

                if (ButtonChoice4.getText() == Answer){
                    Score = Score + 1;
                    updateScore(Score);
                    updateQuestion();

                    Toast.makeText(MathActivity.this, "correct", Toast.LENGTH_SHORT).show();

                }else {
                    Toast.makeText(MathActivity.this, "wrong", Toast.LENGTH_SHORT).show();
                    updateQuestion();
                }
            }
        });

        //End of Button Listener for Button4

        // Start of Button Listener for Skip Button
        ButtonSkip.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){

                Toast.makeText(MathActivity.this, "skipping", Toast.LENGTH_SHORT).show();
                updateQuestion();
            }
        });

        //End of Button Listener for Skip Button

    }

    private void updateQuestion(){
        if(QuestionNumber<5){
            QuestionView.setText(math.getQuestion(QuestionNumber));
            ButtonChoice1.setText(math.getChoice1(QuestionNumber));
            ButtonChoice2.setText(math.getChoice2(QuestionNumber));
            ButtonChoice3.setText(math.getChoice3(QuestionNumber));
            ButtonChoice4.setText(math.getChoice4(QuestionNumber));

            Answer = math.getCorrectAnswer(QuestionNumber);
            QuestionNumber++;
        }else {
            Intent intent = new Intent(MathActivity.this, ScoreActivity.class);
            intent.putExtra("Score", Score);
            startActivity(intent);
        }
    }


    private void updateScore(int point) {
        ScoreView.setText("" + Score);
    }
}