package com.example.suma_resta_radio

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        operar.setOnClickListener {
            resultado.text="";
            if((valor_a.text.toString()=="") or (valor_b.text.toString()=="")){
                resultado.text="Porfavor introducde los  valores "
            }else if(suma.isChecked){
                resultado.text="Resultado:${valor_a.text.toString().toInt()+valor_b.text.toString().toInt()}" ;

            }else if(resta.isChecked) {
                resultado.text="Resultado:${valor_a.text.toString().toInt()-valor_b.text.toString().toInt()}";


            }else{

                resultado.text="Operacion no valida";

            }

            valor_a.text.clear();
            valor_b.text.clear();


        }
    }
}