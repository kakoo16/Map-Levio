package esprit.tn.entities;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the Reclamations database table.
 * 
 */
@Entity
@Table(name="Reclamations")
@NamedQuery(name="Reclamation.findAll", query="SELECT r FROM Reclamation r")
public class Reclamation implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="ReclamationId")
	private int reclamationId;

	@Column(name="Message_content")
	private String message_content;

	@Column(name="Message_object")
	private String message_object;

	//bi-directional many-to-one association to AspNetUser
	@ManyToOne
	@JoinColumn(name="CatFK")
	private AspNetUser aspNetUser;


	public Reclamation(int reclamationId,String message_content, String message_object) {
		super();
		this.reclamationId=reclamationId;
		this.message_content = message_content;
		this.message_object = message_object;
	}
	public Reclamation(String message_content, String message_object) {
		super();
		this.message_content = message_content;
		this.message_object = message_object;
	}
	public Reclamation() {
	}

	public int getReclamationId() {
		return this.reclamationId;
	}

	public void setReclamationId(int reclamationId) {
		this.reclamationId = reclamationId;
	}

	public String getMessage_content() {
		return this.message_content;
	}

	public void setMessage_content(String message_content) {
		this.message_content = message_content;
	}

	public String getMessage_object() {
		return this.message_object;
	}

	public void setMessage_object(String message_object) {
		this.message_object = message_object;
	}

	public AspNetUser getAspNetUser() {
		return this.aspNetUser;
	}

	public void setAspNetUser(AspNetUser aspNetUser) {
		this.aspNetUser = aspNetUser;
	}

	@Override
	public String toString() {
		return "Reclamation [reclamationId=" + reclamationId + ", message_content=" + message_content
				+ ", message_object=" + message_object + ", aspNetUser=" + aspNetUser + "]";
	}

}