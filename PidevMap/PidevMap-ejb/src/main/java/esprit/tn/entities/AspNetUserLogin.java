package esprit.tn.entities;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the AspNetUserLogins database table.
 * 
 */
@Entity
@Table(name="AspNetUserLogins")
@NamedQuery(name="AspNetUserLogin.findAll", query="SELECT a FROM AspNetUserLogin a")
public class AspNetUserLogin implements Serializable {
	private static final long serialVersionUID = 1L;

	@EmbeddedId
	private AspNetUserLoginPK id;

	//bi-directional many-to-one association to AspNetUser
	@ManyToOne
	@JoinColumn(name="UserId" , insertable=false , updatable=false )
	private AspNetUser aspNetUser;

	public AspNetUserLogin() {
	}

	public AspNetUserLoginPK getId() {
		return this.id;
	}

	public void setId(AspNetUserLoginPK id) {
		this.id = id;
	}

	public AspNetUser getAspNetUser() {
		return this.aspNetUser;
	}

	public void setAspNetUser(AspNetUser aspNetUser) {
		this.aspNetUser = aspNetUser;
	}

}