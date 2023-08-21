package com.moin.learnorzo;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.util.Patterns;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

public class SignupActivity extends AppCompatActivity {
    EditText edtName, edtUsername, edtEmail, edtPassword;
    Button btnSignup, btnSignin;

    FirebaseDatabase rootNode;
    DatabaseReference reference;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_signup);

        edtName = (EditText) findViewById(R.id.editName);
        edtUsername = (EditText) findViewById(R.id.editUsername);
        edtEmail = (EditText) findViewById(R.id.editEmail);
        edtPassword = (EditText) findViewById(R.id.editPass);
        btnSignup = (Button) findViewById(R.id.buttonSignUp);
        btnSignin = (Button) findViewById(R.id.buttonSignIn);



        btnSignup.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String name = edtName.getText().toString().trim();
                String username = edtUsername.getText().toString().trim();
                String email = edtEmail.getText().toString().trim();
                String password = edtPassword.getText().toString().trim();

                if (TextUtils.isEmpty(name)) {
                    edtName.setError("You must enter your name!");
                    return;
                }

                if (TextUtils.isEmpty(username)) {
                    edtUsername.setError("You must enter your username!");
                    return;
                }

                if (TextUtils.isEmpty(email)) {
                    edtEmail.setError("You must enter your email!");
                    return;
                }else {
                    if(!(Patterns.EMAIL_ADDRESS.matcher(email).matches())){
                        edtEmail.setError("You must enter valid email!!");
                        return;
                    }
                }

                if (TextUtils.isEmpty(password)) {
                    edtPassword.setError("You must enter your password!");
                    return;
                }else {
                    if (password.length() < 6) {
                        edtPassword.setError("Password too short, enter minimum 6 characters!");
                        return;
                    }
                }

                rootNode = FirebaseDatabase.getInstance();
                reference = rootNode.getReference("User");

                UserInformation userInformation = new UserInformation(name, username, email, password);
                reference.child(username).setValue(userInformation);

                Intent intent = new Intent(SignupActivity.this, MainActivity.class);
                Toast.makeText(SignupActivity.this, "New account created.", Toast.LENGTH_LONG).show();
                startActivity(intent);

            }
        });

        btnSignin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(SignupActivity.this, SigninActivity.class);
                startActivity(intent);
            }
        });
    }
}
