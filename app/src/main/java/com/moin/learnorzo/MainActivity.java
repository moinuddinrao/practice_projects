package com.moin.learnorzo;

import androidx.appcompat.app.AppCompatActivity;
import androidx.cardview.widget.CardView;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.LinearLayout;

import com.moin.learnorzo.questionlibrary.English;
import com.moin.learnorzo.questionlibrary.Science;

public class MainActivity extends AppCompatActivity {

    CardView layoutScience, layoutMath, layoutEnglish;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        layoutScience = findViewById(R.id.layScience);
        layoutMath = findViewById(R.id.layMath);
        layoutEnglish = findViewById(R.id.layEnglish);

        layoutScience.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, ScienceActivity.class);
                startActivity(intent);
            }
        });

        layoutMath.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, MathActivity.class);
                startActivity(intent);
            }
        });

        layoutEnglish.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, EnglishActivity.class);
                startActivity(intent);
            }
        });

    }
}