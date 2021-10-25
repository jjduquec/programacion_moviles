package com.example.notificacionsimple

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_main.*


class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        val numeroAleatorio=(Math.random() * 100_001).toInt()
        Toast.makeText(this, "Memoriza este numero: ${numeroAleatorio}", Toast.LENGTH_LONG).show()
        bt.setOnClickListener {
            //obtenemos el numero
            if(numeroAleatorio==numero.text.toString().toInt()){
                Toast.makeText(this, "CORRECTO!", Toast.LENGTH_LONG).show()

            }else{

                Toast.makeText(this, "Ups! Te equivocaste", Toast.LENGTH_LONG).show()
            }

        }


    }
}