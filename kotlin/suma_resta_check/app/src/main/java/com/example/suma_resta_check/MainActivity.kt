package com.example.suma_resta_check

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        calcular.setOnClickListener {

            if(suma.isChecked){
                resultado.text="Resultado:${valor_a.text.toString().toInt()+valor_b.text.toString().toInt()}"
            }else if(restar.isChecked){
                resultado.text="Resultado:${valor_a.text.toString().toInt()-valor_b.text.toString().toInt()}"

            }else{
                resultado.text="Operacion no valida";

            }

        }
    }
}