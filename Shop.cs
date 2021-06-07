using UnityEngine;
using System.Collections;

public class Shop : MonoBehaviour {

   bool showShop;
   public GameObject[] shopItems;
   public string[] shopItemsName;
   public int[] shopItemsPrice;
   public int[] comprar;
   public Transform player,vendedor;
   public float distance;
   public string teclaShow = "b";
   public int money = 10000;

   void Start(){
      foreach (GameObject g in shopItems){
         g.SetActive(false);
      }
   }
   void Update(){
      if(Vector3.Distance(player.position, vendedor.position) < distance && Input.GetKeyDown(teclaShow)){
         showShop = !showShop;
      }
   }
   void OnGUI(){
      if (!showShop) return;
      GUI.Label (new Rect(10, 10, 100, 20), "Dinheiro: " + money);

      for(int i = 0; i < shopItemsName.Length; i++){
        if(comprar[i] <= 4)
            if ( GUI.Button (new Rect((110*i), 70, 120, 30), shopItemsName[i] + " " + comprar[i] + ": " + shopItemsPrice[i])) {
            purchaseItem(i);
         }
      }
   }
   void purchaseItem(int i){
      if (money < shopItemsPrice[i]) {
         OnInsuficientMoney(shopItemsPrice[i]);
         return;
      }
      if (comprar[i] <= 4)
      {
        money -= shopItemsPrice[i] ;
        addItem(i);
      }
   }
   void addItem(int i){
      shopItems[i].SetActive(true);
      showShop = false;
      shopItemsPrice[i] += shopItemsPrice[i];
      comprar [i] += 1;
   }
   void OnInsuficientMoney(int price){
      // crie aqui seu aviso quando o jogador não tem o dinheiro.
      print("Faltam " + price + " para poder comprar este item");
      showShop = false;
   }
}

