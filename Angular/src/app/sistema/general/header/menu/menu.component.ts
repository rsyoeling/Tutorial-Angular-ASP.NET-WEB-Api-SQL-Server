import { Component, OnInit } from '@angular/core';
import { AccesoperfilService } from 'src/app/core/layout/accesoperfil.service';
import { AuthenticationService } from 'src/app/core/user/authentication.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  accesoPerfil=[]

  constructor(private service: AccesoperfilService,
    private authenticationService: AuthenticationService) { }

  //: void 
  ngOnInit(){
    this.service.GetAccesoPerfil(this.authenticationService.currentUserValue[0]['idRol']).subscribe(data=>this.accesoPerfil=data);
    //this.accesoPerfil=this.service.GetAccesoPerfil("1");
  }

  onDataMenu(){
    console.log(this.accesoPerfil)
  }

  hostClickHandler(item: string) {
    alert(item);
  }
}
