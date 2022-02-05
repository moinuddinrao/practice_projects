package com.moin.learnorzo;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.util.Patterns;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.Query;
import com.google.firebase.database.ValueEventListener;

public class SigninActivity extends AppCompatActivity {
    EditText edtUsername, edtPassword;
    Button btnSignup, btnSignin;
    FirebaseAuth auth;
    boolean isValid;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

//        //Get Firebase auth instance
//        auth = FirebaseAuth.getInstance();
//
//        if (auth.getCurrentUser() != null) {
//            startActivity(new Intent(SigninActivity.this, MainActivity.class));
//            finish();
//        }

        setContentView(R.layout.activity_signin);

        edtUsername = findViewById(R.id.Username);
        edtPassword = findViewById(R.id.Pass);
        btnSignup = findViewById(R.id.SignUp);
        btnSignin = findViewById(R.id.SignIn);

//        //Get Firebase auth instance
//        auth = FirebaseAuth.getInstance();

        btnSignup.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i = new Intent(SigninActivity.this, SignupActivity.class);
                startActivity(i);
            }
        });

        btnSignin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
//                String email = edtEmail.getText().toString();
//                final String password = edtPassword.getText().toString();
                checkLogin();

                if (isValid) {
                    validateUser();
                }
            }

        });


    }

    private void validateUser() {
        String userName = edtUsername.getText().toString().trim();
        String userPassword = edtPassword.getText().toString().trim();
        DatabaseReference reference = FirebaseDatabase.getInstance().getReference("User");

        Query checkUser = reference.orderByChild("username").equalTo(userName);
        checkUser.addListenerForSingleValueEvent(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {

                if (snapshot.exists()) {

                    String passwordFromDB = snapshot.child(userName).child("password").getValue(String.class);

                    if (passwordFromDB.equals(userPassword)) {

                        String nameFromDB = snapshot.child(userName).child("name").getValue(String.class);

                        Intent intent = new Intent(SigninActivity.this, MainActivity.class);
                        startActivity(intent);

                    }
                } else {
                    Toast.makeText(SigninActivity.this, "No user found", Toast.LENGTH_LONG).show();
                }
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });


    }

//    boolean isEmail(EditText text) {
//        CharSequence email = text.getText().toString();
//        return (!TextUtils.isEmpty(email) && Patterns.EMAIL_ADDRESS.matcher(email).matches());
//    }
    boolean isEmpty(EditText text) {
        CharSequence str = text.getText().toString();
        return TextUtils.isEmpty(str);
    }

    void checkLogin() {
        isValid = true;
        if (isEmpty(edtUsername)) {
            edtUsername.setError("You must enter username to login!");
            isValid = false;
        }
//        else {
//            if (!isEmail(edtUsername)) {
//                edtUsername.setError("Enter valid email!");
//                isValid = false;
//            }
//        }

        if (isEmpty(edtPassword)) {
            edtPassword.setError("You must enter password to login!");
            isValid = false;
        } else {
            if (edtPassword.getText().toString().length() < 6) {
                edtPassword.setError("Password must be at least 6 characters long!");
                isValid = false;
            }
        }
    }

}