import { Component, OnInit } from '@angular/core';
import { AccesoperfilService } from 'src/app/core/layout/accesoperfil.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  accesoPerfil=[]

  constructor(private service: AccesoperfilService) { }

  //: void 
  ngOnInit(){
    this.service.GetAccesoPerfil("1").subscribe(data=>this.accesoPerfil=data);
    //this.accesoPerfil=this.service.GetAccesoPerfil("1");
  }

  onDataMenu(){
    console.log(this.accesoPerfil)
  }

  hostClickHandler(item: string) {
    alert(item);
  }
}
