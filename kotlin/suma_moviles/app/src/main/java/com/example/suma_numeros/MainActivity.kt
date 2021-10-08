package com.example.suma_numeros

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.widget.EditText
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)


        sumar.setOnClickListener {

            val num_a=valor_a.text.toString().toInt();
            val num_b=valor_b.text.toString().toInt();
            val suma=num_a+num_b;
            resultado.text="Resultado ${suma.toString()}";
            valor_a.text.clear();
            valor_b.text.clear();














        }

    }
}