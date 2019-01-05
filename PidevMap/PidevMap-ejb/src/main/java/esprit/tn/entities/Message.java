package esprit.tn.entities;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the Messages database table.
 * 
 */
@Entity
@Table(name="Messages")
@NamedQuery(name="Message.findAll", query="SELECT m FROM Message m")
public class Message implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="MessageId")
	private int messageId;

	@Column(name="Cost")
	private float cost;

	@Column(name="Message_content")
	private String message_content;

	@Column(name="Message_object")
	private String message_object;

	private int nombredejours;

	//bi-directional many-to-one association to AspNetUser
	@ManyToOne
	@JoinColumn(name="CatFK")
	private AspNetUser aspNetUser1;

	//bi-directional many-to-one association to AspNetUser
	@ManyToOne
	@JoinColumn(name="Administrator_Id")
	private AspNetUser aspNetUser2;

	public Message() {
	}

	public int getMessageId() {
		return this.messageId;
	}

	public void setMessageId(int messageId) {
		this.messageId = messageId;
	}

	public float getCost() {
		return this.cost;
	}

	public void setCost(float cost) {
		this.cost = cost;
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

	public int getNombredejours() {
		return this.nombredejours;
	}

	public void setNombredejours(int nombredejours) {
		this.nombredejours = nombredejours;
	}

	public AspNetUser getAspNetUser1() {
		return this.aspNetUser1;
	}

	public void setAspNetUser1(AspNetUser aspNetUser1) {
		this.aspNetUser1 = aspNetUser1;
	}

	public AspNetUser getAspNetUser2() {
		return this.aspNetUser2;
	}

	public void setAspNetUser2(AspNetUser aspNetUser2) {
		this.aspNetUser2 = aspNetUser2;
	}

}