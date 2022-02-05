package com.moin.learnorzo;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;

public class ScoreActivity extends AppCompatActivity {

    private TextView ScoreView;
    private Button ButtonBack;

    private int Score;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_score);

        ButtonBack = (Button)findViewById(R.id.Back);
        ScoreView = (TextView)findViewById(R.id.Score);

        Intent intent = getIntent();
        Score = intent.getIntExtra("Score",0);

        updateScore(Score);

        //Start of Button Listener for Back Button
        ButtonBack.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){
                Intent intent = new Intent(ScoreActivity.this, MainActivity.class);
                startActivity(intent);
            }
        });

        //End of Button Listener for Back Button

    }

    private void updateScore(int point) {
        ScoreView.setText("" + Score);
    }

}