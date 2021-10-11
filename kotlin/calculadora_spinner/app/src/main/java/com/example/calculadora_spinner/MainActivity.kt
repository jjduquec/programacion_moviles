package com.example.calculadora_spinner

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.widget.ArrayAdapter
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {
    val lista= listOf("Seleccionar","Sumar","Restar","Multiplicar","Dividir");
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        //creamos el adaptador
        val  adaptador=ArrayAdapter(this,R.layout.support_simple_spinner_dropdown_item,lista);
        //pasamos el adaptador al spinner
        spinner.adapter=adaptador;

        calcular.setOnClickListener {

            //comprobamos que nos hayan pasado datos
            if((valor_a.text.toString()=="")or(valor_b.text.toString()=="")){
                resultado.text="Entrada invalida, porfavor intenta de nuevo"

            }else{
                /*
                determinamos la operacion seleccionada por el usuario
                 */

                val operacion=spinner.selectedItem.toString();

                if(operacion=="Seleccionar"){
                    resultado.text="Operacion Invalida";


                }else if(operacion=="Sumar"){
                    resultado.text="Resultado:${valor_a.text.toString().toInt()+valor_b.text.toString().toInt()}"


                }else if(operacion=="Restar"){
                    resultado.text="Resultado:${valor_a.text.toString().toInt()-valor_b.text.toString().toInt()}"


                }else if(operacion=="Multiplicar"){

                    resultado.text="Resultado:${valor_a.text.toString().toInt()*valor_b.text.toString().toInt()}"


                }else{
                    resultado.text="Resultado:${valor_a.text.toString().toInt()/valor_b.text.toString().toInt()}"

                }







            }





        }


    }





}