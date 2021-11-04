package com.example.proyecto013

import android.content.Context
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_main.*


class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        val preferencias=getSharedPreferences("datos",Context.MODE_PRIVATE)
        bt_registrar.setOnClickListener {
            val email=email_vw.text.toString();
            val editor=preferencias.edit()
            editor.putString("email",email);
            editor.commit();
            email_vw.setText("");


        }

        bt_recuperar.setOnClickListener {
            registro_vw.setText(preferencias.getString("email","No registrado"));


        }

    }
}