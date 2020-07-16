import { Component, OnInit,Input, Output, EventEmitter } from '@angular/core';
import { AccesoperfilService } from 'src/app/core/layout/accesoperfil.service';
import { AuthenticationService } from 'src/app/core/user/authentication.service';

@Component({
  selector: 'app-submenu',
  templateUrl: './submenu.component.html',
  styleUrls: ['./submenu.component.css']
})
export class SubmenuComponent implements OnInit {

  accesoPerfil=[]

  constructor(private service: AccesoperfilService,
    private authenticationService: AuthenticationService) { }

  ngOnInit(): void {
    this.service.GetAccesoPerfil(this.authenticationService.currentUserValue[0]['idRol']).subscribe(data=>this.accesoPerfil=data)
  }
  //stackblitz
  @Input() x: number;
  @Input() y: string;
  @Output() clickedItem = new EventEmitter<string>();
  
  clickHandler(item: string) {
    this.clickedItem.emit(item);
  }
}
