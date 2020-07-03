import { Injectable } from '@angular/core';

import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Accesoperfil } from './accesoperfil.model';

@Injectable({
  providedIn: 'root'
})
export class AccesoperfilService {
  
  readonly rootURL ="https://localhost:44305/api";

  constructor(private http: HttpClient) { }

    GetAccesoPerfil(idRol: string):Observable<Accesoperfil[]>{
      let options=new HttpParams();
      options= options.append('idRol', idRol);
      return this.http.get<Accesoperfil[]>(this.rootURL+'/Layout', {params:options});
    }
}
