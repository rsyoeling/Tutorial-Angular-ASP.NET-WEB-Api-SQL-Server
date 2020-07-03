import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { MenuComponent } from './sistema/general/header/menu/menu.component';
import { SubmenuComponent } from './sistema/general/header/submenu/submenu.component';
import { InicioComponent } from './sistema/general/login/inicio/inicio.component';
import { CreatePerfilComponent } from './sistema/administracion/perfil/create-perfil/create-perfil.component';
import { ListPerfilComponent } from './sistema/administracion/perfil/list-perfil/list-perfil.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatToolbarModule } from '@angular/material/toolbar';
import { AccesoperfilService } from './core/layout/accesoperfil.service';
import { HttpClientModule } from '@angular/common/http';

import { MatButtonModule } from '@angular/material/button';
import { MatMenuModule } from '@angular/material/menu';
import { MatIconModule } from '@angular/material/icon';

const appRoutes: Routes=[
  { path:'create', component: CreatePerfilComponent },
  { path:'list', component: ListPerfilComponent },
  { path:'', redirectTo:'/list', pathMatch:'full' }
]

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    SubmenuComponent,
    InicioComponent,
    CreatePerfilComponent,
    ListPerfilComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatToolbarModule,
    MatButtonModule,
    MatMenuModule,
    MatIconModule,
    RouterModule.forRoot(appRoutes) 
  ],
  providers: [AccesoperfilService],
  bootstrap: [AppComponent]
})
export class AppModule { }
