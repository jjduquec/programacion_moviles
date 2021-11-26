import * as React from 'react';
import { Text, View, StyleSheet,
TextInput,Button,TouchableOpacity,
Picker,Keyboard } from 'react-native';
import Constants from 'expo-constants';

// You can import from local files
import AssetExample from './components/AssetExample';

// or any pure javascript modules available in npm
import { Card } from 'react-native-paper';

export default class App extends React.Component {

    state = {
      radioButton:'value1',
      text1:'',
      text2:'',
      resultado:'0',
      operacion:'suma'};


ejecutarOperacion(valor1, valor2)
  {
Keyboard.dismiss();
if(!!valor1 && !!valor2)
{
    var a=parseFloat(valor1),b=parseFloat(valor2);
    var c=0;
    var op="";
    
 if(this.state.operacion=="suma") 
 {
    c=a+b;
    op='+';
 }
  if(this.state.operacion=="resta") 
  {  
    c=a-b;
    op="-";
  }  
 if(this.state.operacion=="multiplicacion") 
  {  
    c=a*b;
    op="x";
  } 
    if(c)
  this.setState({resultado: a+op+b+"="+c}) ;
}
else
   this.setState({resultado: 'Error en los datos!!'}) ;  
  }

updateOperacion = (operacionseleccionada) => {
      this.setState({ operacion: operacionseleccionada })
   }


  render() {
    
    return (
      <View style={{padding: 10,fontSize:24,marginTop:15}}>
      <Text style={{padding: 15, fontSize: 24,backgroundColor:'orange',color: 'white',
      textAlign:'center'}}>
       Suma de dos numeros
      </Text>
      
      <TextInput
        style={{height: 40,borderColor:'green',borderWidth:2,padding:5,marginTop:10}}
        placeholder="Valor 1"
        onChangeText={(text1) => this.setState({text1})}
        keyboardType='numeric'
      />
      

      <TextInput
        style={{height: 40,borderColor:'green',borderWidth:2,padding:5,marginTop:5}}
        placeholder="Valor 2"
        onChangeText={(text2) => this.setState({text2})}
         keyboardType='numeric'
      />
    
<Picker selectedValue = {this.state.operacion} onValueChange = {this.updateOperacion} style={{marginTop:5}}>
               <Picker.Item label = "Suma" value = "suma" />
               <Picker.Item label = "Resta" value = "resta" />
               <Picker.Item label = "Multiplicación" value = "multiplicacion" />
</Picker>

 

 <TouchableOpacity 
    style={{height: 60,backgroundColor:'blue',marginTop:5,textAlignVertical:'center'}}
    onPress={() => {
                    this.ejecutarOperacion(this.state.text1,this.state.text2);
                  }
        }
>
<Text style={{color:'white',fontSize:24,textAlignVertical:'center',textAlign: "center"}}>Ejecutaremos</Text>
</TouchableOpacity>

      <Text style={{padding: 10, fontSize: 32}}>
        {this.state.resultado}
      </Text>
      <Text style={{padding: 10, fontSize: 16}}>
       Operación seleccionada : {this.state.operacion}
      </Text>
</View>
    );
  }
}


