package com.example.dos_activitys

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_detalles.*

class Detalles : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_detalles)
        bt_regresar.setOnClickListener {

            var principal=Intent(this,MainActivity::class.java);
            startActivity(principal);



        }
    }
}