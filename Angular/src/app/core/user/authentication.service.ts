import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { AUsuario } from './authentication.model';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  readonly rootURL ="https://localhost:44305/api";

  private currentUserSubject: BehaviorSubject<any>;
  public currentUser: Observable<any>;

  constructor(private http: HttpClient) {
    this.currentUserSubject = new BehaviorSubject<any>(JSON.parse(localStorage.getItem('currentUser')));
    this.currentUser = this.currentUserSubject.asObservable();  
  }

  public get currentUserValue() {
    return this.currentUserSubject.value;
  }

  GetAuthenticate(usuario: string, contrasena: string) {
    let options = new HttpParams();
    options = options.append('usuario', usuario);
    options = options.append('contrasena', contrasena);

    return this.http.get<AUsuario[]>(this.rootURL+'/Login', { params: options })
          .pipe(map(user => {
            localStorage.setItem('currentUser', JSON.stringify(user));
            this.currentUserSubject.next(user);
            return user;
          }));
  }

  logout() {
    localStorage.removeItem('currentUser');
    this.currentUserSubject.next(null);
  }

}
